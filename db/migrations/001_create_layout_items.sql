-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, ratio, label, active) VALUES (9.23, 44.27, 'staging', 21);
INSERT INTO layout_items (weight, ratio, label, active) VALUES (68.82, 91.68, 'fallback', 47);
INSERT INTO layout_items (weight, ratio, label, active) VALUES (97.2, 5.69, 'fallback', 4);
