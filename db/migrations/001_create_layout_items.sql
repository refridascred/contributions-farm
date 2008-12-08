-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio, state, level, rank) VALUES ('local', 61.37, 'primary', 3, 34);
INSERT INTO layout_items (token, ratio, state, level, rank) VALUES ('green', 37.29, 'blue', 97, 44);
INSERT INTO layout_items (token, ratio, state, level, rank) VALUES ('local', 79.41, 'cached', 87, 83);
