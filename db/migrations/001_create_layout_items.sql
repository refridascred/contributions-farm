-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, weight, count) VALUES ('open', 87.37, 20);
INSERT INTO layout_items (token, weight, count) VALUES ('standard', 2.68, 61);
INSERT INTO layout_items (token, weight, count) VALUES ('green', 62.29, 39);
