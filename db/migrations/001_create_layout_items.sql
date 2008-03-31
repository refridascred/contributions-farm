-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, region, token) VALUES ('latest', 64.04, 'open', 'staging');
INSERT INTO layout_items (owner, ratio, region, token) VALUES ('primary', 44.42, 'green', 'primary');
INSERT INTO layout_items (owner, ratio, region, token) VALUES ('eu-west', 27.08, 'open', 'edge');
