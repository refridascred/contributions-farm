-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, level, region, rank, token) VALUES (52, 75, 'eu-west', 77, 'latest');
INSERT INTO layout_items (active, level, region, rank, token) VALUES (80, 7, 'staging', 83, 'strict');
