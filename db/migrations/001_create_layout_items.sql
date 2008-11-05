-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (active, token, ratio) VALUES (20, 'local', 68.29);
INSERT INTO layout_items (active, token, ratio) VALUES (44, 'stable', 1.6);
INSERT INTO layout_items (active, token, ratio) VALUES (16, 'local', 33.36);
