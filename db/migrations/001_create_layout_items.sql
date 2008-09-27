-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, count, region, owner, rank) VALUES ('blue', 68, 'standard', 'fallback', 1);
INSERT INTO layout_items (label, count, region, owner, rank) VALUES ('stable', 4, 'legacy', 'latest', 30);
INSERT INTO layout_items (label, count, region, owner, rank) VALUES ('stable', 53, 'eu-west', 'cached', 80);
