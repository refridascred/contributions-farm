-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, owner, region, token) VALUES (44, 'local', 'green', 'green');
INSERT INTO layout_items (active, owner, region, token) VALUES (78, 'staging', 'standard', 'strict');
INSERT INTO layout_items (active, owner, region, token) VALUES (56, 'strict', 'eu-west', 'cached');
