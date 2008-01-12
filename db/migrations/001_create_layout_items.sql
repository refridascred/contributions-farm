-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (active, count, region) VALUES (86, 59, 'cached');
INSERT INTO layout_items (active, count, region) VALUES (1, 53, 'eu-west');
INSERT INTO layout_items (active, count, region) VALUES (11, 21, 'latest');
