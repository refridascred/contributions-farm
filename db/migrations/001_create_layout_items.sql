-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, label, score) VALUES (56, 'legacy', 11.5);
INSERT INTO layout_items (active, label, score) VALUES (16, 'latest', 35.06);
INSERT INTO layout_items (active, label, score) VALUES (41, 'legacy', 77.8);
