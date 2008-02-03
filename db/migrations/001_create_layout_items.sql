-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, region, count, token) VALUES ('latest', 'eu-west', 2, 'latest');
INSERT INTO layout_items (owner, region, count, token) VALUES ('eu-west', 'blue', 18, 'local');
INSERT INTO layout_items (owner, region, count, token) VALUES ('latest', 'staging', 92, 'staging');
