-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, token, ratio, region) VALUES ('edge', 'latest', 33.09, 'local');
INSERT INTO layout_items (owner, token, ratio, region) VALUES ('strict', 'green', 73.78, 'green');
