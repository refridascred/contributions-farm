-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, label, active) VALUES (41.62, 'stable', 13);
INSERT INTO layout_items (weight, label, active) VALUES (53.62, 'green', 41);
INSERT INTO layout_items (weight, label, active) VALUES (94.9, 'primary', 23);
