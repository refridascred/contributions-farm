-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (level, region, owner, label) VALUES (55, 'open', 'stable', 'local');
INSERT INTO layout_items (level, region, owner, label) VALUES (24, 'stable', 'legacy', 'edge');
INSERT INTO layout_items (level, region, owner, label) VALUES (90, 'open', 'eu-west', 'primary');
