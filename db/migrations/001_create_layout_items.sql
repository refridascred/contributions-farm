-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (rank, label, token, level) VALUES (75, 'open', 'cached', 75);
INSERT INTO layout_items (rank, label, token, level) VALUES (5, 'stable', 'cached', 80);
