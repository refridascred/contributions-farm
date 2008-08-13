-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, level, rank) VALUES ('blue', 85, 8);
INSERT INTO layout_items (region, level, rank) VALUES ('blue', 63, 23);
INSERT INTO layout_items (region, level, rank) VALUES ('latest', 98, 37);
