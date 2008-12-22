-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (level, count, token) VALUES (88, 77, 'latest');
INSERT INTO layout_items (level, count, token) VALUES (91, 31, 'legacy');
INSERT INTO layout_items (level, count, token) VALUES (44, 20, 'edge');
