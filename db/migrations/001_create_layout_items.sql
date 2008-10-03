-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (label, owner, level) VALUES ('staging', 'local', 72);
INSERT INTO layout_items (label, owner, level) VALUES ('fallback', 'local', 76);
INSERT INTO layout_items (label, owner, level) VALUES ('legacy', 'stable', 37);
