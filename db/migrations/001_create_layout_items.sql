-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (score, token, active, count, ratio) VALUES (10.29, 'fallback', 40, 30, 23.08);
INSERT INTO layout_items (score, token, active, count, ratio) VALUES (78.57, 'standard', 87, 96, 4.07);
INSERT INTO layout_items (score, token, active, count, ratio) VALUES (90.41, 'local', 55, 16, 21.44);
