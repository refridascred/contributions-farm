-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (level, region, count) VALUES (38, 'latest', 13);
INSERT INTO layout_items (level, region, count) VALUES (65, 'primary', 19);
INSERT INTO layout_items (level, region, count) VALUES (24, 'blue', 82);
