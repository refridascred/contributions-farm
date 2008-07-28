-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio, state) VALUES ('green', 12.06, 'latest');
INSERT INTO layout_items (token, ratio, state) VALUES ('green', 71.65, 'green');
INSERT INTO layout_items (token, ratio, state) VALUES ('legacy', 67.42, 'local');
