-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, owner, region, active) VALUES (47.58, 'green', 'primary', 51);
INSERT INTO layout_items (ratio, owner, region, active) VALUES (1.05, 'stable', 'eu-west', 66);
INSERT INTO layout_items (ratio, owner, region, active) VALUES (80.43, 'latest', 'strict', 2);
