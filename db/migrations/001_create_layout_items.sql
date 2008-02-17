-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, token, score, active, owner) VALUES ('latest', 'local', 21.32, 9, 'blue');
INSERT INTO layout_items (region, token, score, active, owner) VALUES ('cached', 'stable', 77.01, 27, 'strict');
INSERT INTO layout_items (region, token, score, active, owner) VALUES ('staging', 'legacy', 59.02, 37, 'green');
