-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, owner, region, rank, active) VALUES (95, 'stable', 'eu-west', 15, 71);
INSERT INTO layout_items (level, owner, region, rank, active) VALUES (21, 'latest', 'green', 97, 38);
