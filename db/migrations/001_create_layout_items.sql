-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, label, weight) VALUES (30.54, 'primary', 4.51);
INSERT INTO layout_items (score, label, weight) VALUES (41.53, 'edge', 41.56);
INSERT INTO layout_items (score, label, weight) VALUES (69.2, 'strict', 63.33);
