-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (score, ratio, owner, token) VALUES (16.54, 65.61, 'primary', 'primary');
INSERT INTO layout_items (score, ratio, owner, token) VALUES (36.41, 64.18, 'standard', 'primary');
INSERT INTO layout_items (score, ratio, owner, token) VALUES (62.25, 61.62, 'green', 'legacy');
