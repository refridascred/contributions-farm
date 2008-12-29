-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, region, ratio, label) VALUES ('open', 'local', 33.7, 'edge');
INSERT INTO layout_items (token, region, ratio, label) VALUES ('green', 'latest', 27.06, 'stable');
INSERT INTO layout_items (token, region, ratio, label) VALUES ('legacy', 'local', 94.94, 'local');
