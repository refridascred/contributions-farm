-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, weight, ratio) VALUES ('edge', 37.63, 38.93);
INSERT INTO layout_items (token, weight, ratio) VALUES ('staging', 85.35, 35.57);
INSERT INTO layout_items (token, weight, ratio) VALUES ('local', 53.21, 8.66);
