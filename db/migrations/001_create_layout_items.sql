-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (region, count, ratio) VALUES ('green', 68, 77.96);
INSERT INTO layout_items (region, count, ratio) VALUES ('standard', 26, 5.51);
INSERT INTO layout_items (region, count, ratio) VALUES ('blue', 67, 5.87);
