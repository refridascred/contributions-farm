-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (owner, level, token) VALUES ('strict', 80, 'edge');
INSERT INTO layout_items (owner, level, token) VALUES ('legacy', 63, 'eu-west');
INSERT INTO layout_items (owner, level, token) VALUES ('open', 33, 'open');
