-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, score, level) VALUES ('fallback', 19.49, 42);
INSERT INTO layout_items (owner, score, level) VALUES ('strict', 63.3, 91);
INSERT INTO layout_items (owner, score, level) VALUES ('primary', 56.63, 90);
