-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, token, region, score, owner) VALUES ('fallback', 'cached', 'standard', 28.61, 'stable');
INSERT INTO layout_items (label, token, region, score, owner) VALUES ('latest', 'fallback', 'stable', 65.5, 'stable');
INSERT INTO layout_items (label, token, region, score, owner) VALUES ('primary', 'stable', 'fallback', 76.46, 'open');
