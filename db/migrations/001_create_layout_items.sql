-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, region, owner, rank) VALUES (65.98, 'staging', 'eu-west', 51);
INSERT INTO layout_items (ratio, region, owner, rank) VALUES (61.51, 'open', 'stable', 87);
