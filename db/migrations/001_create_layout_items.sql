-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (label, owner, score) VALUES ('fallback', 'strict', 22.8);
INSERT INTO layout_items (label, owner, score) VALUES ('primary', 'latest', 57.82);
INSERT INTO layout_items (label, owner, score) VALUES ('blue', 'green', 29.75);
