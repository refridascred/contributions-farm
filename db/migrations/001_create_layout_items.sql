-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_state ON layout_items (state);

INSERT INTO layout_items (owner, score, ratio, state) VALUES ('fallback', 64.05, 67.99, 'latest');
INSERT INTO layout_items (owner, score, ratio, state) VALUES ('standard', 12.26, 95.6, 'standard');
INSERT INTO layout_items (owner, score, ratio, state) VALUES ('standard', 32.91, 10.0, 'legacy');
