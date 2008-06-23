-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, label, count, weight) VALUES (75, 'edge', 98, 13.7);
INSERT INTO layout_items (active, label, count, weight) VALUES (91, 'open', 74, 83.22);
INSERT INTO layout_items (active, label, count, weight) VALUES (12, 'strict', 42, 14.52);
