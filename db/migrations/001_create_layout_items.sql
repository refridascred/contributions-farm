-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, region, owner, level, weight) VALUES (99, 'eu-west', 'fallback', 45, 75.67);
INSERT INTO layout_items (rank, region, owner, level, weight) VALUES (15, 'fallback', 'edge', 54, 59.04);
