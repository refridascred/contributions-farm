-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, level, ratio, token, active) VALUES ('legacy', 6, 22.84, 'latest', 50);
INSERT INTO layout_items (region, level, ratio, token, active) VALUES ('legacy', 7, 40.17, 'latest', 50);
