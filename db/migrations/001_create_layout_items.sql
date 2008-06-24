-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (token, weight, owner, score, active) VALUES ('latest', 64.04, 'cached', 94.88, 49);
INSERT INTO layout_items (token, weight, owner, score, active) VALUES ('fallback', 34.54, 'local', 25.59, 99);
