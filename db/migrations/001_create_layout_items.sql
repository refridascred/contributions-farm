-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, ratio, score, weight) VALUES ('legacy', 79.01, 73.97, 60.74);
INSERT INTO layout_items (token, ratio, score, weight) VALUES ('primary', 13.57, 11.74, 45.5);
INSERT INTO layout_items (token, ratio, score, weight) VALUES ('staging', 23.53, 50.82, 0.06);
