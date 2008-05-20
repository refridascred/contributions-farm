-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, weight, token) VALUES ('open', 76.31, 21.31, 'latest');
INSERT INTO layout_items (owner, ratio, weight, token) VALUES ('legacy', 66.13, 55.97, 'edge');
