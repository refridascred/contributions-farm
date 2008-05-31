-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, count, weight) VALUES (87.64, 71, 66.82);
INSERT INTO layout_items (ratio, count, weight) VALUES (38.1, 7, 20.97);
INSERT INTO layout_items (ratio, count, weight) VALUES (87.58, 67, 78.61);
