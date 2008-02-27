-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, token, owner, ratio, level) VALUES (87, 'standard', 'primary', 39.15, 39);
INSERT INTO layout_items (active, token, owner, ratio, level) VALUES (61, 'staging', 'fallback', 57.91, 1);
INSERT INTO layout_items (active, token, owner, ratio, level) VALUES (56, 'strict', 'open', 36.22, 13);
