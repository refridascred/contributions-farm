-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (weight, score, token, active) VALUES (28.47, 9.25, 'staging', 52);
INSERT INTO layout_items (weight, score, token, active) VALUES (30.67, 9.21, 'fallback', 53);
