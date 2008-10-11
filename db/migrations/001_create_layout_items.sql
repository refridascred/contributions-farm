-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (owner, score, label, level) VALUES ('fallback', 9.58, 'primary', 60);
INSERT INTO layout_items (owner, score, label, level) VALUES ('local', 77.86, 'latest', 40);
