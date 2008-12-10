-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, rank, region, level) VALUES (66, 79, 'stable', 96);
INSERT INTO layout_items (active, rank, region, level) VALUES (24, 78, 'local', 75);
INSERT INTO layout_items (active, rank, region, level) VALUES (85, 39, 'strict', 9);
