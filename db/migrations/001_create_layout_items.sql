-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, rank, region) VALUES (59, 13, 'open');
INSERT INTO layout_items (level, rank, region) VALUES (34, 53, 'standard');
INSERT INTO layout_items (level, rank, region) VALUES (30, 85, 'open');
