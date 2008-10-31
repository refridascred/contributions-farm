-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, label, score, owner) VALUES (10, 'standard', 40.78, 'primary');
INSERT INTO layout_items (level, label, score, owner) VALUES (98, 'eu-west', 61.09, 'legacy');
INSERT INTO layout_items (level, label, score, owner) VALUES (88, 'staging', 6.59, 'legacy');
