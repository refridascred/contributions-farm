-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, state, ratio, token, weight) VALUES (67, 'local', 67.17, 'edge', 10.71);
INSERT INTO layout_items (active, state, ratio, token, weight) VALUES (96, 'blue', 58.33, 'primary', 65.88);
INSERT INTO layout_items (active, state, ratio, token, weight) VALUES (62, 'staging', 70.42, 'fallback', 66.58);
