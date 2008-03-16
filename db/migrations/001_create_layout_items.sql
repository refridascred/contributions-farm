-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, owner, token, region) VALUES (21, 'eu-west', 'open', 'latest');
INSERT INTO layout_items (level, owner, token, region) VALUES (67, 'blue', 'fallback', 'standard');
