-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (weight, active, score, label, count) VALUES (31.06, 84, 10.03, 'strict', 51);
INSERT INTO layout_items (weight, active, score, label, count) VALUES (94.09, 98, 50.84, 'legacy', 3);
