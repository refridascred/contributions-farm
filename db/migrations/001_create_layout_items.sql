-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (weight, active, label, count) VALUES (91.3, 43, 'legacy', 48);
INSERT INTO layout_items (weight, active, label, count) VALUES (30.55, 22, 'open', 51);
INSERT INTO layout_items (weight, active, label, count) VALUES (91.93, 3, 'legacy', 21);
