-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, owner, token, region) VALUES (15, 'latest', 'stable', 'edge');
INSERT INTO layout_items (active, owner, token, region) VALUES (53, 'primary', 'green', 'green');
