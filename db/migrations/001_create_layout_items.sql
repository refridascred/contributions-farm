-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, region, token, owner, level) VALUES (38, 'blue', 'edge', 'blue', 64);
INSERT INTO layout_items (rank, region, token, owner, level) VALUES (29, 'legacy', 'fallback', 'primary', 78);
INSERT INTO layout_items (rank, region, token, owner, level) VALUES (92, 'eu-west', 'green', 'latest', 3);
