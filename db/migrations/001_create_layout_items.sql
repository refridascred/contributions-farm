-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (label, count, level, owner, token) VALUES ('blue', 96, 73, 'eu-west', 'open');
INSERT INTO layout_items (label, count, level, owner, token) VALUES ('primary', 57, 11, 'standard', 'fallback');
