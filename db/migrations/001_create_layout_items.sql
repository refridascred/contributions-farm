-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (state, owner, score, region, count) VALUES ('primary', 'eu-west', 67.95, 'eu-west', 62);
INSERT INTO layout_items (state, owner, score, region, count) VALUES ('standard', 'staging', 23.89, 'open', 76);
INSERT INTO layout_items (state, owner, score, region, count) VALUES ('fallback', 'stable', 33.25, 'legacy', 18);
