-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, ratio, token) VALUES ('open', 63.89, 'green');
INSERT INTO layout_items (owner, ratio, token) VALUES ('strict', 6.6, 'open');
INSERT INTO layout_items (owner, ratio, token) VALUES ('stable', 38.69, 'latest');
