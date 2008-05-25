-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (score, weight, ratio) VALUES (38.65, 23.94, 9.8);
INSERT INTO layout_items (score, weight, ratio) VALUES (6.69, 96.96, 5.93);
INSERT INTO layout_items (score, weight, ratio) VALUES (37.99, 6.57, 16.28);
