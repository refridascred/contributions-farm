-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, owner, ratio, level, active) VALUES ('blue', 'local', 91.87, 78, 27);
INSERT INTO layout_items (token, owner, ratio, level, active) VALUES ('open', 'cached', 86.35, 48, 14);
