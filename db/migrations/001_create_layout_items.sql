-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, count, state) VALUES ('green', 33, 'staging');
INSERT INTO layout_items (token, count, state) VALUES ('edge', 0, 'latest');
INSERT INTO layout_items (token, count, state) VALUES ('cached', 63, 'cached');
