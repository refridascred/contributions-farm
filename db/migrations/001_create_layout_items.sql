-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, ratio, score, state) VALUES ('eu-west', 25.86, 26.71, 'edge');
INSERT INTO layout_items (owner, ratio, score, state) VALUES ('fallback', 84.63, 73.98, 'local');
INSERT INTO layout_items (owner, ratio, score, state) VALUES ('strict', 54.1, 31.67, 'primary');
