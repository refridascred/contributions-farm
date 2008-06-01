-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, weight, ratio, count) VALUES ('staging', 27.91, 18.9, 66);
INSERT INTO layout_items (region, weight, ratio, count) VALUES ('primary', 18.14, 68.8, 90);
