-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (label, rank, token) VALUES ('edge', 96, 'open');
INSERT INTO layout_items (label, rank, token) VALUES ('open', 91, 'latest');
