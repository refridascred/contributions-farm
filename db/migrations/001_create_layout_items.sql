-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, score, count, label, region) VALUES ('strict', 61.82, 27, 'fallback', 'open');
INSERT INTO layout_items (token, score, count, label, region) VALUES ('staging', 7.58, 93, 'primary', 'strict');
INSERT INTO layout_items (token, score, count, label, region) VALUES ('standard', 20.87, 39, 'primary', 'legacy');
